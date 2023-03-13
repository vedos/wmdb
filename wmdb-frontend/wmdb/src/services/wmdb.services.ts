import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import {  Item, Search } from '../models';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class WMDBService {

  constructor(private http: HttpClient) {}

  items(search: Search){
    let queryParams = new HttpParams();
    
    if(search.category != null)
      queryParams = queryParams.append('category',search.category || '');
    
    if(search.search != null)
      queryParams = queryParams.append('search',search.search || '');

    queryParams = queryParams.append('page',search.page || 1);

    queryParams = queryParams.append('pageSize',search.pageSize || 0);

    return this.http.get<Item[]>(`${environment.apiUrl}/items/search`, {params: queryParams})
  }

  rate(id: number, rating: number){

    var body = { 
      "ItemId" : id,
      "Rating" : rating
    }
    
    return this.http.post<Item[]>(`${environment.apiUrl}/items/rate`, body)
  }
}
