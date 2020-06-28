import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { dragula, DragulaService } from 'ng2-dragula';

@Component({
  selector: 'app-upload-ordered-image',
  templateUrl: './upload-ordered-image.component.html',
  styleUrls: ['./upload-ordered-image.component.scss'],
  providers: [DragulaService]
})
export class UploadOrderedImageComponent implements OnInit {
  @Input('dataSource') dataSource;
  @Input('baseUrl') baseUrl;
  @Input('multiple') multiple: boolean = false;
  @Output('onDelete') onDelete = new EventEmitter();
  @Output('onUpload') onUpload = new EventEmitter();
  @Output('onSave') onSave = new EventEmitter();
  constructor(private dragula: DragulaService) {
  }

  ngOnInit() {
  }

  onFileSelected(event) {
    if (this.multiple == false)
      this.onUpload.emit(event.target.files[0]);
    else this.onUpload.emit(event.target.files);
  }

  delete(id: number) {
    this.onDelete.emit(id);
  }

  save() {
    this.onSave.emit(this.dataSource);
  }

}
