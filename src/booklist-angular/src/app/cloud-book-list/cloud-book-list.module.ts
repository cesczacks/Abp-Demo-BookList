import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CloudBookListRoutingModule } from './cloud-book-list-routing.module';
import { BookListsComponent } from './book-lists/book-lists.component';
import { BooksComponent } from './books/books.component';
import { SharedModule } from '@shared/shared.module';
import { HttpClientModule } from '@angular/common/http';
import { AbpModule } from 'abp-ng2-module/dist/src/abp.module';
import { LocalizationService } from '@shared/i18n/localization.service';
import { TitleService } from '@delon/theme';

@NgModule({
  imports: [
    CommonModule,
    CloudBookListRoutingModule,
    HttpClientModule,
    AbpModule,
    SharedModule
  ],
  declarations: [
    BookListsComponent,
    BooksComponent],
  entryComponents: [
    BookListsComponent,
    BooksComponent],
  providers: [
    LocalizationService,
    TitleService]
})
export class CloudBookListModule { }
