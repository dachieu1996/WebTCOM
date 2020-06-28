import { TransferHttpService } from '@gorniv/ngx-universal';
import { Injectable, PLATFORM_ID, Inject } from '@angular/core';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class PortfolioService extends BaseService {
  baseApiUrl='api/Project/';
  constructor(http: TransferHttpService, @Inject(PLATFORM_ID) public platformId: Object) {
    super(http, platformId);
   }
  getAll() {
    return this.defaultGet(`${this.baseApiUrl}GetAll`);
  }

  getByLanguageId(languageId: number) {
    let param = {languageId};
    return this.defaultGet(`${this.baseApiUrl}GetByLanguageId`, param);
  }
}
