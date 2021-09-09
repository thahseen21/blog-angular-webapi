import { Injectable } from '@angular/core';
import { Constants } from '../constants/api-constants';

@Injectable({
  providedIn: 'root',
})
export class ApiEndPointService {
  constructor(private path: Constants) {}

  public getBlogEndPoint = (): string =>
    this.createUrl(this.path.WEATHERFORECAST);

  public addCommentEndPoint = (): string =>
    this.createUrl(this.path.ADDCOMMENT);

  public getCommentEndPoint = (): string =>
    this.createUrl(this.path.GETCOMMENT);

  public editBlogEndPoint = (): string => this.createUrl(this.path.EDITBLOG);

  public addBlogEndPoint = (): string => this.createUrl(this.path.ADDBLOG);

  private createUrl = (action: string): string => {
    return this.path.BASE_URL + action;
  };
}
