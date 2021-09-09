import { Component, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { ApiEndPointService } from 'src/app/core/service/api-endpoints.service';
import { ApiHttpService } from 'src/app/core/service/api-http.service';
import { Blog } from 'src/app/data/schema/blog';
import { Comment } from 'src/app/data/schema/comment';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css'],
})
export class BlogComponent implements OnInit {
  public blog!: Blog;

  public commentList: Comment[] = [];

  @ViewChild('comment') textarea: any;

  constructor(
    private router: Router,
    private apiHttpService: ApiHttpService,
    private apiEndPointService: ApiEndPointService
  ) {}

  ngOnInit(): void {
    if (history.state.data) {
      this.blog = history.state.data;
      this.getCommentList();
    } else {
      this.router.navigate(['/']);
    }
  }

  getCommentList() {
    var body = {
      id: this.blog.id,
    };
    this.apiHttpService
      .post(this.apiEndPointService.getCommentEndPoint(), {}, body)
      .subscribe((data) => {
        this.commentList = [...data];
      });
  }

  addNewComment(comment: string) {
    if (comment.length > 0) {
      var body = {
        message: comment,
        blogIdFk: this.blog.id,
      };
      this.apiHttpService
        .post(this.apiEndPointService.addCommentEndPoint(), {}, body)
        .subscribe((value) => this.commentList.push(...this.commentList,value));
      this.textarea.nativeElement.value = ' ';

    }
  }
}
