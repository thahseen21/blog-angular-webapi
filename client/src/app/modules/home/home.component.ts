import { Component, OnInit } from '@angular/core';
import { ApiHttpService } from 'src/app/core/service/api-http.service';
import { ApiEndPointService } from 'src/app/core/service/api-endpoints.service';
import { Blog } from 'src/app/data/schema/blog';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  public blogList: Blog[] = [];

  constructor(
    private apiHttpService: ApiHttpService,
    private apiEndPointService: ApiEndPointService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.apiHttpService
      .get(this.apiEndPointService.getBlogEndPoint(), {
        'access-control-allow-origin': '*',
      })
      .subscribe((data) => {
        this.blogList.push(...data);
      });
  }

  gotoBlog(data: Blog) {
    this.router.navigate(['blog'], { state: { data: data } });
  }

  gotoNewBlog() {
    this.router.navigate(['newblog']);
  }
}
