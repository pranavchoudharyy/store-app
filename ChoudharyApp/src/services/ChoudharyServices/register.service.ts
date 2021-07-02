import { HttpClient , HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable  , throwError} from 'rxjs';
import { catchError} from 'rxjs/operators';
import { ICustomer } from 'src/interfaces/customer';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {
  
  constructor(private http: HttpClient) 
  { 
  }
  RegisterCustomers(customer : ICustomer): Observable<boolean> 
  {
    let tempVar = this.http.post<boolean>('https://localhost:49284/api/Customers/InsertCustomers', + customer).pipe(catchError(this.errorHandler));
    return tempVar;
  }
  errorHandler(error: HttpErrorResponse) {
    return throwError(error.message || "Server Error");
  }
}
