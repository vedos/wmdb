import { Component, OnInit } from '@angular/core';
import { ShareService } from 'src/helper/share.service';
import { Category, Search } from 'src/models';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit{
  categories?: Category[];
  search_param?: string;
  selected_category?: string;
  params?: Search;

  constructor(private shareService: ShareService){    
    this.categories = [ { name:"Movies", tag:"movies"},{name:"TV Shows",tag:"shows"} ];  
    this.selected_category = "movies";
  }
  ngOnInit(): void {
    this.params = {
      category: this.selected_category,
      search: this.search_param
    };
    
    this.shareService.setItem(this.params);
  }

  search(category?:string){
    this.selected_category = category;
    
    this.params = {
      category: this.selected_category,
      search: this.search_param
    };

    this.shareService.setItem(this.params);
  }

  typing(){
    let search_temp = this.search_param;
    this.delay(500).then(() => {
      if(search_temp == this.search_param)   
        this.search(this.selected_category);
    })
  }

  delay(t:number, v?:any) {
    return new Promise(resolve => setTimeout(resolve, t, v));
  }
}
