import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { ICustomer } from 'src/interfaces/customer';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  customer : ICustomer[]
  constructor(private http: HttpClient) 
  { 
    this.customer = []
  }
  RegisterCustomers(emailId : string,password : string):Observable<boolean> {
    var custObj : ICustomer;
    custObj = {firstName: '',lastName:'' ,emailId : emailId,secondaryEmailId : '',customerPassword : password,phone : 0 ,secondaryPhone : 0,gender : '',dateOfBirth : '' ,address : ''};
    return this.http.post<boolean>('https://localhost:49284/api/Customers/ValidateCredentials', custObj).pipe(catchError(this.errorHandler));
  }
  errorHandler(error: HttpErrorResponse) {
    console.error(error);
    return throwError(error.message || "Server Error");
  }
}

