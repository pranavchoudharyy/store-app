import { Injectable } from '@angular/core';
import {ICustomer} from 'src/interfaces/customer';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class CustomerService 
{
  customer : ICustomer[];

  constructor(private http:HttpClient) 
  { 
    this.customer =[]
  }
  getCustomers() : Observable<ICustomer[]>
  {
    let tempVar = this.http.get<ICustomer[]>('https://localhost:49284/api/Customers');
    return tempVar;
  }


}
