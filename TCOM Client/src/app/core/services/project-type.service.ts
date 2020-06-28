import { TransferHttpService } from '@gorniv/ngx-universal';
import { Injectable, PLATFORM_ID, Inject } from '@angular/core';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class ProjectTypeService extends BaseService {
  baseApiUrl = 'api/ProjectType/';
  constructor(http: TransferHttpService, @Inject(PLATFORM_ID) public platformId: Object) {
    super(http, platformId);
  }

  getForPage(languageId: number) {
    let param = { languageId }
    return this.defaultGet(`${this.baseApiUrl}GetForPage`, param);
  }

}
