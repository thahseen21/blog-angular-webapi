import { Component, OnInit } from '@angular/core';
import { ApiEndPointService } from 'src/app/core/service/api-endpoints.service';
import { ApiHttpService } from 'src/app/core/service/api-http.service';
import { Router } from '@angular/router';
import { Blog } from 'src/app/data/schema/blog';

@Component({
  selector: 'app-new-blog',
  templateUrl: './new-blog.component.html',
  styleUrls: ['./new-blog.component.css'],
})
export class NewBlogComponent implements OnInit {
  public blog!: Blog;
  public isEdit: boolean = false;

  constructor(
    private router: Router,
    private apiEndPointService: ApiEndPointService,
    private apiHttpService: ApiHttpService
  ) {}

  ngOnInit(): void {
    console.log(history.state.data);
    if (history.state.data) {
      this.isEdit = true;
      this.blog = history.state.data;
    }
  }

  goBack() {
    return this.router.navigate(['/']);
  }

  addNewBlog(title: string, content: string) {
    if (this.isEdit) {
      let body = {
        id: this.blog.id,
        title: title,
        content: content,
      };
      this.apiHttpService
        .put(this.apiEndPointService.editBlogEndPoint(), {}, body)
        .subscribe();
      alert('edited blog');
      this.goBack();
    } else {
      let body = {
        title: title,
        content: content,
      };
      this.apiHttpService
        .post(this.apiEndPointService.addBlogEndPoint(), {}, body)
        .subscribe();
      alert('added new blog');
      this.goBack();
    }
  }
}
