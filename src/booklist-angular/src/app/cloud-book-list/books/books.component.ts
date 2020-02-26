import { Component, OnInit, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/component-base';
import { BookListDto, BookServiceProxy } from '@shared/service-proxies/service-proxies';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.less'],
  animations: [appModuleAnimation()]
})
export class BooksComponent extends PagedListingComponentBase<BookListDto> implements OnInit {

  constructor(
    injector: Injector,
    private bookService: BookServiceProxy) {
    super(injector);
  }


  protected fetchDataList(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {

    this.bookService.getPagedBookAsync(
      this.filterText,
      request.sorting,
      request.skipCount,
      request.maxResultCount).pipe(
        finalize(() => {
          finishedCallback();
        })
      ).subscribe(result => {
        this.dataList = result.items;
        this.showPaging(result);
      });

  }

  ngOnInit() {
    this.refresh();
  }

}
