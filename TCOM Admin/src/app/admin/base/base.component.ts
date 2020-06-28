import { MatSnackBar } from '@angular/material/snack-bar';
import { OnInit, Injector } from '@angular/core';

export abstract class BaseComponent implements OnInit {
  private _snackBar: MatSnackBar;

  constructor(injector: Injector) { 
    this._snackBar = injector.get(MatSnackBar);
  }

  ngOnInit() {
  }

  notify(message, action) {
    this._snackBar.open(message, action, {
      duration: 7000,
      horizontalPosition: 'right',
      verticalPosition: 'bottom',
    });
  }
}
