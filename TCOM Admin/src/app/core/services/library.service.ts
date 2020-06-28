import { Injectable } from '@angular/core';
import { BaseService } from './base.service';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LibraryService extends BaseService {
  baseApiUrl: string = "api/Library/";
  constructor(http: HttpClient) {
    super(http);
   }

  uploadFile(image: File, saveByName: boolean = false, folderName: string = "") {
    let formData = new FormData();
    formData.append('files', image, image.name);
    return this.defaultUploadFile(`${this.baseApiUrl}UploadFile?saveByName=${saveByName}&folderName=${folderName}`, formData);
  }
}
