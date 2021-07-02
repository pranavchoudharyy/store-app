import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { ViewCategoryComponent } from './view-category/view-category.component';
import { ViewCustomerComponent } from './view-customer/view-customer.component';
import { ViewProductComponent } from './view-product/view-product.component';

const routes: Routes = [
  { path: 'ViewCategory', component: ViewCategoryComponent },
  { path: 'ViewCustomer', component: ViewCustomerComponent },
  { path: '', component: ViewProductComponent },
  { path: 'Registration', component: RegisterComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
