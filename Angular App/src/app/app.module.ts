import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';
import { AppComponent } from './app.component';
import { MasterComponent } from './Components/master/master.component';
import { Routes, RouterModule } from '@angular/router';
import { AddComponentComponent } from './Components/add-component/add-component.component';
import { EditComponentComponent } from './Components/edit-component/edit-component.component';
import { FormsModule } from '@angular/forms';

const routes : Routes =[
  {path:'', redirectTo:'/books', pathMatch:'full'},
  {path:'books', component:MasterComponent},
  {path:'books/edit/:id', component: EditComponentComponent},
  {path:'books/addNew', component: AddComponentComponent}
]
@NgModule({
  declarations: [
    AppComponent,
    MasterComponent,
    AddComponentComponent,
    EditComponentComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
