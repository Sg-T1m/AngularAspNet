import { IProduct } from 'src/app/Interface/IProduct';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IComponentsType } from '../Interface/IComponentsType';
import { GetDataService } from '../Services/GetData.service';
@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html',
})
export class CounterComponent implements OnInit {
  constructor(public http: HttpClient, public GetDataService: GetDataService) {}
  produckts?: IProduct[];
  Ozy?: IComponentsType[];
  Proces: any[] = [];
  Materink: IComponentsType[] = [];
  Disk?: IComponentsType[];
  BlockPitania?: IComponentsType[];
  Kyler?: IComponentsType[];
  VideoCard?: IComponentsType[];
  test: any[] = [];
  ngOnInit() {
    // this.http.get<IProduct[]>('weatherforecasts').subscribe(result => {
    //   this.produckts = result;
    //   console.log(result)
    // }, error => console.error(error));
    this.GetDataService.getAll('weatherforecasts/2').subscribe(
      (result: any) => {
        this.produckts = result;
      }
    );
    console.log(this.Proces)
  }

  getMaterinka() {
    if ((this.Proces.length == 0)) {
      this.GetDataService.getAll('weatherforecasts/2').subscribe(
        (result: any) => {
          this.Materink = result;
          console.log(result)
        }
      );
    } else {
      this.GetDataService.getAll(`weatherforecasts/all/${this.Proces[1].CompatibilitiesId}`).subscribe(

        (result: any) => {
          this.Materink?.push(result[0].ComponentId2Navigation)
      
        }
      );
    }
  }
  getProces() {
    this.GetDataService.getAll('weatherforecasts/3').subscribe(
      (result: any) => {
        this.Proces = result;
        console.log(this.Proces[1].CompatibilitiesId)
      }
    );
  }
  getVideoCard() {
    this.GetDataService.getAll('weatherforecasts/6').subscribe(
      (result: any) => {
        this.VideoCard = result;
      }
    );
  }
  getOzy() {
    this.GetDataService.getAll('weatherforecasts/1').subscribe(
      (result: any) => {
        this.Ozy = result;
      }
    );
  }
  getDisk() {
    this.GetDataService.getAll('weatherforecasts/7').subscribe(
      (result: any) => {
        this.Disk = result;
        console.log(result);
      }
    );
  }
  getBlockPitania() {
    this.GetDataService.getAll('weatherforecasts/4').subscribe(
      (result: any) => {
        this.BlockPitania = result;
      }
    );
  }
  getKyler() {
    this.GetDataService.getAll('weatherforecasts/9').subscribe(
      (result: any) => {
        this.Kyler = result;
      }
    );
  }
}
