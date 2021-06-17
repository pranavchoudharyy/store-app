import { Component, OnInit } from '@angular/core';
import { ICategory } from 'src/interfaces/category';
import { CategoryService } from 'src/services/ChoudharyServices/category.service';
@Component({
  selector: 'app-view-category',
  templateUrl: './view-category.component.html',
  styleUrls: ['./view-category.component.css']
})
export class ViewCategoryComponent implements OnInit 
{
  categories: ICategory[];
  showMsgDiv: boolean = false;
  

  constructor(private _categoryService : CategoryService) 
  {
    this.categories =[]
  }

  ngOnInit()
  {
    this.getCategory();
  }
  getCategory()
  {
    this._categoryService.getCategories().subscribe
    (
      res=> this.categories = res
    );
}
}
