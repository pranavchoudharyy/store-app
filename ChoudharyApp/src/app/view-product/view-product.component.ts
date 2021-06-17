import { Component, OnInit } from '@angular/core';
import { IProduct } from 'src/interfaces/product';
import { ProductService } from 'src/services/ChoudharyServices/product.service';


@Component({
  selector: 'app-view-product',
  templateUrl: './view-product.component.html',
  styleUrls: ['./view-product.component.css']
})

export class ViewProductComponent implements OnInit 
{
  products : IProduct[];
  showMsgDiv: boolean = false;

  constructor(private _productService : ProductService) { 
    this.products =[]
  }

  ngOnInit(): void 
  {
    this.getProducts()
  }
  getProducts()
  {
    this._productService.getproducts().subscribe
    (
      res=> this.products = res
    );

  }
}
