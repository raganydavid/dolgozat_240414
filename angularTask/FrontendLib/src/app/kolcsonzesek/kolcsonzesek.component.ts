import { Component } from '@angular/core';
import { BaseService } from '../base.service';


@Component({
  selector: 'app-kolcsonzesek',
  standalone: true,
  imports: [],
  templateUrl: './kolcsonzesek.component.html',
  styleUrl: './kolcsonzesek.component.css'
})
export class KolcsonzesekComponent {
  @Input() kolcsonzokId:any;
  @Input() kolcsonzesek:any;

  newKolcs:any={}
  oszlopok =["sz1","sz2","sz3","sz4","sz5","sz6"]
  constructor(private base:BaseService){}
  newKolcsonzesek(){
    this.newKolcs.kolcsonzokId=this.kolcsonzokId
    this.base.newKolcs(this.newKolcs)
  }
  updateKolcs(kolcs:any){
    this.base.updateKolcs(kolcs)
  }
  deleteKolcs(kolcs:any){
    this.base.deleteKolcs(kolcs)
  }
}
