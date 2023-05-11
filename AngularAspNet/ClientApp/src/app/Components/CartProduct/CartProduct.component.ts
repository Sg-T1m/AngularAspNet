import { Component, OnInit, Input } from '@angular/core';
import { IProduct } from 'src/app/Interface/IProduct';

@Component({
  selector: 'app-CartProduct',
  templateUrl: './CartProduct.component.html',
  styleUrls: ['./CartProduct.component.css']
})
export class CartProductComponent implements OnInit {

  constructor() { }
  @Input() Produck?: IProduct
  ngOnInit() {
  }

}
