import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Book } from 'src/app/Models/book';
import { BooksService } from 'src/app/Services/books.service';

@Component({
  selector: 'app-edit-component',
  templateUrl: './edit-component.component.html',
  styleUrls: ['./edit-component.component.css']
})
export class EditComponentComponent implements OnInit {

  bookId: string | null ="";
  foundBook : Book = {} as Book;
  constructor(private service : BooksService, private activedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.activedRoute.paramMap.subscribe((param)=>{
      this.bookId = param.get("id");
      if(this.bookId != null){
        this.service.getRecord(parseInt(this.bookId)).subscribe((data)=>{
          this.foundBook = data;
        })
      }
    })
  }
}
