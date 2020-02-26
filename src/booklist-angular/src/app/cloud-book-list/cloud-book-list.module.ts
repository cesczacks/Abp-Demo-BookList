import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CloudBookListRoutingModule } from './cloud-book-list-routing.module';
import { BookListsComponent } from './book-lists/book-lists.component';
import { BooksComponent } from './books/books.component';

@NgModule({
  imports: [
    CommonModule,
    CloudBookListRoutingModule
  ],
  declarations: [BookListsComponent, BooksComponent]
})
export class CloudBookListModule { }
