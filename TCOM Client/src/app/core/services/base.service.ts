import { TransferHttpService } from '@gorniv/ngx-universal';
import { ResponseResult } from './../models/response-result';
import { environment } from './../../../environments/environment';
import { HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Inject, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';

export abstract class BaseService {
  public url: string = environment.BASE_URL;

  constructor(private http: TransferHttpService, @Inject(PLATFORM_ID) public platformId: Object) {
  }

  public setHeader() {
    let headers = null;
    try {
      if (isPlatformBrowser(this.platformId)) {
        const token = localStorage.getItem('token');
        if (token !== '') {
          headers = new HttpHeaders({ 'Content-Type': 'application/json', Authorization: 'Bearer ' + token });
        } else { headers = new HttpHeaders({ 'Content-Type': 'application/json' }); }
      }
    } catch (e) {
      headers = new Headers({ 'Content-Type': 'application/json' });
    }
    return headers;
  }

  public defaultGet(apiname: string, params: any = {}, debug: boolean = false): Promise<ResponseResult> {
    const linknew = this.url + apiname + '?' + this.objToQuery(params);
    if (debug === true) { console.log(linknew); }
    return this.http.get<ResponseResult>(linknew, new HttpErrorResponse({ headers: this.setHeader() })).toPromise();
  }

  public defaultPost(apiname: string, data: any = {}, params: any = {}, debug: boolean = false): Promise<ResponseResult> {
    const linknew = this.url + apiname + '?' + this.objToQuery(params);
    if (debug === true) { console.log(linknew); }
    return this.http.post<ResponseResult>(linknew, JSON.stringify(data), new HttpErrorResponse({ headers: this.setHeader() })).toPromise();
  }

  public defaultPut(apiname: string, data: any = {}, params: any = {}, debug: boolean = false): Promise<ResponseResult> {
    const linknew = this.url + apiname + '?' + this.objToQuery(params);
    if (debug === true) { console.log(linknew); }
    return this.http.put<ResponseResult>(linknew, JSON.stringify(data), new HttpErrorResponse({ headers: this.setHeader() })).toPromise();
  }

  public defaultDelete(apiname: string, data: any = {}, params: any = {}, debug: boolean = false): Promise<ResponseResult> {
    const linknew = this.url + apiname + '?' + this.objToQuery(params);
    if (debug === true) { console.log(linknew); }
    return this.http.delete<ResponseResult>(linknew, new HttpErrorResponse({ headers: this.setHeader() })).toPromise();
  }

  objToQuery(obj) {
    let qrstr = Object.keys(obj).reduce(function (a, k) {
      a.push(k + '=' + encodeURIComponent(obj[k])); return a;
    }, []).join('&');
    if (qrstr !== '') { qrstr = '&' + qrstr; }
    return qrstr;
  }
}
