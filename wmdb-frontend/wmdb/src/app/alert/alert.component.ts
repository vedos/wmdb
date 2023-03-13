import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { AlertService } from 'src/helper/alert.service';

@Component({
  selector: 'app-alert',
  templateUrl: './alert.component.html',
  styleUrls: ['./alert.component.scss']
})
export class AlertComponent implements OnInit, OnDestroy {
  private subscription: Subscription;
  message: any;

  constructor(private alertService: AlertService) {
    this.subscription = new Subscription();
    this.message = {};
  }

  ngOnInit() {
    this.subscription = this.alertService
      .getAlert()
      .subscribe(data => {
        switch (data && data.type) {
          case 'success':
            data.isShown = true; //alert-success
            break;
          case 'error':
            data.isError = true; //alert-success
            break;
        }
        this.message = data;


        setTimeout(() => {
          if (this.message.isShown) {
            this.message.isShown = false;
            this.message.isShown = false;
          }
        }, 2000);
      });
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
}

export interface Message {
  isShown: boolean;
  type: string;
  text: string;
}
