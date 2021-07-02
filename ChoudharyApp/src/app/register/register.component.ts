import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, ReactiveFormsModule, FormControl, NgForm, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ICustomer } from 'src/interfaces/customer';
import { RegisterService } from 'src/services/ChoudharyServices/register.service';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})

export class RegisterComponent implements OnInit {

  registerForm! : FormGroup
  errorMsg : string
  result : boolean
  customer! : ICustomer
  message : string

  constructor(private _regSer: RegisterService, 
     private form: FormBuilder, 
     private router : Router , 
     private http : HttpClient) 
  { 
      this.registerForm = this.form.group({
      fName :['',[Validators.required, Validators.pattern('^[a-zA-z]{2,128}$'),Validators.minLength,Validators.maxLength]],
      lName : ['',[Validators.required, Validators.pattern('^[a-zA-z]{2,128}$'),Validators.minLength,Validators.maxLength]],
      emaill: ['',[Validators.required]],
      semail : ['',[Validators.required]],
      password : ['',[Validators.required,Validators.minLength]],
      phone : [91,[Validators.required,Validators.pattern('[0-9]{3}-[0-9]{3}-[0-9]{4}'),Validators.minLength]],
      sphone : [91,[Validators.pattern('[0-9]{3}-[0-9]{3}-[0-9]{4}'),Validators.minLength]],
      gender : ['',[Validators.required]],
      dob : ['',[Validators.required]],
      address :['',[Validators.required]]
      })
      this.customer = 
      {
      firstName : '',
      lastName : '',
      emailId : '',
      secondaryEmailId : '',
      customerPassword : '',
      phone : 91 ,
      secondaryPhone : 91,
      gender : '',
      dateOfBirth : '',
      address : ''
      }
      this.result = false;
      this.errorMsg='';
      this.message = '';
  }
  SubmitForm()
  {
      this.customer = 
      {
      firstName : this.registerForm.get('fName')?.value,
      lastName : this.registerForm.get('lName')?.value,
      emailId : this.registerForm.get('emaill')?.value,
      secondaryEmailId : this.registerForm.get('semail')?.value,
      customerPassword : this.registerForm.get('password')?.value,
      phone : this.registerForm.get('phone')?.value,
      secondaryPhone : this.registerForm.get('sphone')?.value,
      gender : this.registerForm.get('gender')?.value,
      dateOfBirth : this.registerForm.get('dob')?.value,
      address : this.registerForm.get('address')?.value
      }
      console.log(this.customer);
      this._regSer.RegisterCustomers(this.customer).subscribe(
        res => {
          console.log(this.customer)
          this.result = res
          if(this.result == true) 
          {
            alert("Customer Registered Successfully")
            this.router.navigate(["/Registration"])
          }
          else
          {
            alert("there was some error please try again later")
          }
          (responseerror: string) => this.errorMsg = responseerror
        })
  }
  ngOnInit(): void {}
}

