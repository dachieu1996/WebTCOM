import { environment } from './../../../environments/environment';
import { LibraryService } from './../../core/services/library.service';
import { UploadImageComponent } from 'app/shared/upload-image/upload-image.component';
import { CreateLanguage } from './../../core/models/language';
import { LanguageService } from './../../core/services/language.service';
import { HomeService } from './../../core/services/home.service';
import { Component, OnInit, Injector, ViewChild, AfterViewInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { BaseComponent } from '../base/base.component';

@Component({
  selector: 'app-language',
  templateUrl: './language.component.html',
  styleUrls: ['./language.component.scss']
})
export class LanguageComponent extends BaseComponent implements OnInit, AfterViewInit {
  @ViewChild(UploadImageComponent) uploadImageComponent: UploadImageComponent = new UploadImageComponent();
  baseUrl: string = environment.BASE_URL;
  id: number;
  code: string;
  name: string;
  imgUrl: any;
  img: File;
  dataSource: MatTableDataSource<any>;
  displayedColumns: string[] = ['code', 'name', 'image', 'action'];
  constructor(
    injector: Injector,
    private languageService: LanguageService,
    private libraryService: LibraryService
    ) {
    super(injector);
  }

  ngOnInit() {
    this.getData();
  }

  ngAfterViewInit() {
    this.uploadImageComponent.classStyler.stylerHolder = true;
    this.uploadImageComponent.classFormGroup.styleFormGroup = true;
  }


  getData() {
    this.languageService.getAll().then(res => {
      this.dataSource = new MatTableDataSource(res.data);
    })
  }

  add() {
    let newLanguage: CreateLanguage = {
      code: this.code,
      name: this.name,
      imgUrl: this.imgUrl
    }
    this.languageService.add(newLanguage).then(res => {
      if (res.success)
        this.getData();
      this.notify(res.message, "Close");
    })
    this.onCancel();
  }

  update(id: number) {
    let elm = this.dataSource.data.find(val => val.id === id);
    elm.id = this.id;
    elm.code = this.code;
    elm.name = this.name;
    elm.imgUrl = this.imgUrl;
    this.languageService.update(elm).then(res => {
      if (res.success) {
        this.getData();
        this.notify(res.message, 'Close');
      }
    });
    this.onCancel();
  }

  async onSave() {
    if (this.img) {
      await this.libraryService.uploadFile(this.img).then(res => {
        this.imgUrl = res.data.storageLocation;
      });
    }
    if (this.id) {
      this.update(this.id);
    } else {
      this.add();
      this.onCancel();
    }
  }

  onCancel() {
    this.id = null;
    this.code = null;
    this.name = null;
    this.imgUrl = null;
  }

  onEdit(id: number) {
    this.uploadImageComponent.isImageSaved = false;
    let el = this.dataSource.data.find(val => val.id === id);
    this.id = el.id;
    this.code = el.code;
    this.name = el.name;
    this.imgUrl = el.imgUrl;
  }

  onDelete(id: number) {
    this.languageService.delete(id).then(res => {
      if (res.success)
        this.getData();
    });
  }

  uploadImage(img: File) {
    this.img = img;
  }
}
