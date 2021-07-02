import { Injectable } from '@angular/core';
import { IProduct } from 'src/interfaces/product';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class ProductService {
  product : IProduct[]

  constructor(private http:HttpClient) 
  { 
    this.product =[]
  }
  getproducts() : Observable<IProduct[]>
  {
    let tempVar = this.http.get<IProduct[]>('https://localhost:49284/api/Products/GetAllProducts');
    return tempVar;

  }
}
