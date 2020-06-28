import { TransferHttpService } from '@gorniv/ngx-universal';
import { Injectable, Inject, PLATFORM_ID } from '@angular/core';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class ServiceTypeDetailService extends BaseService {
  baseApiUrl: string = 'api/ServTypeDetail/';
  constructor(http: TransferHttpService, @Inject(PLATFORM_ID) public platformId: Object) {
    super(http, platformId);
  }

  getByLanguageId(languageId: number) {
    let params = { languageId };
    return this.defaultGet(`${this.baseApiUrl}GetByLanguageId`, params);
  }

  get(languageId: number, serviceTypeId: number) {
    let params = { languageId, serviceTypeId };
    return this.defaultGet(`${this.baseApiUrl}Get`, params);
  }
}
