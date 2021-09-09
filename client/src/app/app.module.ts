import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './modules/home/home.component';
import { NewBlogComponent } from './modules/new-blog/new-blog.component';
import { HeaderComponent } from './shared/component/header/header.component';
import { BlogComponent } from './modules/blog/blog.component';

@NgModule({
  declarations: [AppComponent, HomeComponent, NewBlogComponent, HeaderComponent, BlogComponent],
  imports: [BrowserModule, HttpClientModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
