import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookListsComponent } from './book-lists/book-lists.component';
import { BooksComponent } from './books/books.component';

const routes: Routes = [{
  path: '',
  children: [{
    path: 'books',
    component: BooksComponent
  },
  {
    path: 'book-lists',
    component: BookListsComponent
  }]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CloudBookListRoutingModule { }
