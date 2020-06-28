import { HomeViewModel } from './../models/home';
import { ResponseResult } from './../models/response-result';
import { BaseService } from './base.service';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HomeService extends BaseService {
  baseApiUrl: string = "api/Home/";
  constructor(http: HttpClient) {
    super(http);
  }

  getAll() {
    return this.defaultGet(this.baseApiUrl + "GetAll");
  }

  getById(id: number) {
    let params = { id: id };
    return this.defaultGet(this.baseApiUrl + 'GetById', params);
  }

  getByLanguageId(languageId: number) {
    let params = { languageId: languageId };
    return this.defaultGet(this.baseApiUrl + 'GetByLanguageId', params);
  }

  add(data: HomeViewModel) {
    return this.defaultPost(this.baseApiUrl + 'Add', [data]);
  }

  update(data: HomeViewModel){
    return this.defaultPut(this.baseApiUrl + 'Update', data);
  }
}
