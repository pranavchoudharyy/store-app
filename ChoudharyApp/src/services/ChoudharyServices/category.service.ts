import { Injectable } from '@angular/core';
import { ICategory } from 'src/interfaces/category';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  categories : any;
  constructor(private http : HttpClient) { }

  getCategories(): Observable<ICategory[]> {
    let tempVar = this.http.get<ICategory[]>('https://localhost:49284/api/Categories');
    return tempVar;
  }
}
