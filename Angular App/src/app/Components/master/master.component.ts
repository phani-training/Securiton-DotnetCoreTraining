import { Component, OnInit } from '@angular/core';
import { Book } from 'src/app/Models/book';
import { BooksService } from 'src/app/Services/books.service';

@Component({
  selector: 'app-master',
  templateUrl: './master.component.html',
  styleUrls: ['./master.component.css']
})
export class MasterComponent implements OnInit {
  bookList : Book[] | null = null;
  constructor(private service : BooksService) { }

  ngOnInit(): void {
    this.service.getAllRecords().subscribe((data)=>{
      this.bookList = data;
    })
  }

}
