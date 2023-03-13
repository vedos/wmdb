import { Component, OnInit } from '@angular/core';
import { AlertService } from 'src/helper/alert.service';
import { ShareService } from 'src/helper/share.service';
import { Item, Search } from 'src/models';
import { WMDBService } from 'src/services/wmdb.services';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  public viewItems: Item[];
  public showMore?: boolean;
  params: Search;
  title?: string;
  pageSize: number = 8;

  constructor(
    private shareService: ShareService,
    private wmdbService: WMDBService,
    private alertService: AlertService
  ) {
    this.viewItems = [];
    this.params = {};
  }

  ngOnInit(): void {
    //searched values
    this.shareService.selectedItem.subscribe((params: Search) => {

      this.title = params.category == 'shows' ? "TV Shows: Top Rated" : "Movies: Top Rated";
      this.params = params;
      this.params.pageSize = this.pageSize;


      this.wmdbService.items(this.params).subscribe({
        next: data => {
          this.viewItems = [];
          data.forEach(x => {
            let item: Item = x as Item;
            this.viewItems.push(item);
          })

          this.showMore = false;
          if(this.viewItems.length == this.pageSize)
              this.showMore = true;          
        },
        error: error => {
          // alert error
        },
        complete: () => {
          console.log('Request complete');
        }
      });
    })
  }

  rate(item:Item) {
    //call api to rate
    if (!isNaN(item.current_rating)) {
      this.wmdbService.rate(item.id, item.current_rating).subscribe({
        next: data => {
          this.alertService.success("Rated: " + data.item.title + " with " + item.current_rating + " starts" );
        },
        error: error => {
          // alert error
        },
        complete: () => {
          item.current_rating = NaN;
          console.log('Request complete');
        }
      });
    }
  }

  viewMore(){      
    if(this.params.page == null)
      this.params.page = 1;

    this.params.page = this.params.page + 1;
    
    this.wmdbService.items(this.params).subscribe({
      next: data => {
        data.forEach(x => {
          let item: Item = x as Item;
          this.viewItems.push(item);
        })

        if(data.length < this.pageSize)
          this.showMore = false;
      },
      error: error => {
        // alert error
      },
      complete: () => {
        console.log('Request complete');
      }
    });
  }
}
