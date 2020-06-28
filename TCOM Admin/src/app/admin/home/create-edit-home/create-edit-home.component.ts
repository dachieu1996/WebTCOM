import { environment } from './../../../../environments/environment';
import { LibraryService } from './../../../core/services/library.service';
import { BaseComponent } from './../../base/base.component';
import { HomeService } from './../../../core/services/home.service';
import { HomeViewModel } from './../../../core/models/home';
import { Component, OnInit, Input, Injector, Output, EventEmitter } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
@Component({
  selector: 'app-create-edit-home',
  templateUrl: './create-edit-home.component.html',
  styleUrls: ['./create-edit-home.component.scss']
})
export class CreateEditHomeComponent extends BaseComponent {
  @Input('languageId') languageId;
  @Output('onSubmitted') onSubmitted = new EventEmitter();
  input: HomeViewModel = {} as HomeViewModel;
  baseUrl: string = environment.BASE_URL;
  firstImg: File;
  secondImg: File;
  // firstImgSrc: string;
  // secondImgSrc: string;
  constructor(
    injector: Injector,
    private homeService: HomeService,
    private libraryService: LibraryService
  ) {
    super(injector);
  }

  ngOnInit() {
    this.getDataByLanguageId();
  }

  async getDataByLanguageId() {
    await this.homeService.getByLanguageId(this.languageId).then(res => {
      if (res.data)
        this.input = res.data;
    })
  }

  async onSubmit() {
    this.input.languageId = this.languageId;
    if (this.firstImg) {
      await this.libraryService.uploadFile(this.firstImg).then(res => {
        this.input.firstImgUrl = res.data.storageLocation;
      });
    }

    if (this.secondImg) {
      await this.libraryService.uploadFile(this.secondImg).then(res => {
        this.input.sencondImgUrl = res.data.storageLocation;
      });
    }

    if (this.input.id) {
      this.homeService.update(this.input).then(res => {
        this.notify(res.message, 'Close');
      })
    } else {
      this.homeService.add(this.input).then(async res => {
        await this.getDataByLanguageId();
        this.notify(res.message, 'Close');
      })
    }

    this.onSubmitted.emit();
  }

  uploadFirstImage(image: File) {
    this.firstImg = image;
  }

  uploadSecondImage(image: File) {
    this.secondImg = image;
  }
}