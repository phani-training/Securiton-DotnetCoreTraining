import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from '../Models/book';

@Injectable({
  providedIn: 'root'
})
export class BooksService {
  strUrl : string = "http://localhost:5273/api/BooksApi"
  constructor(private http: HttpClient) { }

  getAllRecords () : Observable<Book[]>{
    return this.http.get<Book[]>(this.strUrl);
  }

  getRecord(id: number) : Observable<Book>{
    let tempUrl = `${this.strUrl}/${id}`;
    return this.http.get<Book>(tempUrl);
  }

  addNewBook(book : Book) : Observable<any>{
    return this.http.post(this.strUrl, book);
  }

  updateBookDetails(book: Book) : Observable<any>{
    return this.http.put(this.strUrl, book);
  }

  deleteBook(id : number) :Observable<any>{
    let tempUrl = `${this.strUrl}/{id}`
    return this.http.delete(tempUrl);
  }


}
