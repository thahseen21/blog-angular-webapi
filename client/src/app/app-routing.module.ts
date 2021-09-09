import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BlogComponent } from './modules/blog/blog.component';
import { HomeComponent } from './modules/home/home.component';
import { NewBlogComponent } from './modules/new-blog/new-blog.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'newblog', component: NewBlogComponent },
  { path: 'blog', component: BlogComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
