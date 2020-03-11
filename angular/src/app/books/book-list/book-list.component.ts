import { Component, OnInit } from '@angular/core';
import { Store, Select } from '@ngxs/store';
import { BooksState } from 'src/app/store/states/books.state';
import { Observable } from 'rxjs';
import { Books } from 'src/app/store/models/books';
import { GetBooks } from 'src/app/store/actions/books.actions';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.scss']
})
export class BookListComponent implements OnInit {
  @Select(BooksState.getBooks)
  books$: Observable<Books.Book[]>;

  booksType = Books.BookType;

  loading = false;

  constructor(private store: Store) {}

  ngOnInit(): void {
    this.get();
  }

  get() {
    this.loading = true;

    this.store.dispatch(new GetBooks()).subscribe(() => {
      this.loading = false;
    });
  }
}
