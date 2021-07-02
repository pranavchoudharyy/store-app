import { Injectable } from '@angular/core';
import { ICategory } from 'src/interfaces/category';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class CategoryService {
  categories : ICategory[];
  constructor(private http : HttpClient) 
  { 
    this.categories=[];
  }
  getCategories() : Observable<ICategory[]> 
  {
    let tempVar = this.http.get<ICategory[]>('https://localhost:49284/api/Categories/GetAllCategories');
    return tempVar;
  }
}
