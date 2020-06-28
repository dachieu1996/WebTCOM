import { Injectable, PLATFORM_ID, Inject } from '@angular/core';
import { TransferHttpService } from '@gorniv/ngx-universal';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class HomeService extends BaseService {
  baseApiUrl: string = "api/Home/";

  constructor(http: TransferHttpService, @Inject(PLATFORM_ID) public platformId: Object) {
    super(http, platformId);
  }

  getByLanguageId(languageId: number) {
    let params = { languageId }
    return this.defaultGet(this.baseApiUrl + "GetByLanguageId", params);
  }

}
