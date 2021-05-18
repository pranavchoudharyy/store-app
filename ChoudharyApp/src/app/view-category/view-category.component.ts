import { Component, OnInit } from '@angular/core';
import { ICategory } from 'src/interfaces/category';
import { CategoryService } from 'src/services/ChoudharyServices/category.service';
@Component({
  selector: 'app-view-category',
  templateUrl: './view-category.component.html',
  styleUrls: ['./view-category.component.css']
})
export class ViewCategoryComponent implements OnInit {
  categories: any;
  showMsgDiv: boolean = false;
  private _categoryService : any;

  constructor() {}

  ngOnInit()
  {
    this.getCategories();

  }
  getCategories() {
    this._categoryService.getCategories().subscribe(
      (      responseCategoryData: any) => this.categories = responseCategoryData
    );
  

}
}
