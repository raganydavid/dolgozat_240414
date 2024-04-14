import { Component, OnDestroy, OnInit } from '@angular/core';
import { BaseService } from '../base.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-kolcsonzok',
  standalone: true,
  imports: [],
  templateUrl: './kolcsonzok.component.html',
  styleUrl: './kolcsonzok.component.css'
})
export class KolcsonzokComponent implements OnInit, OnDestroy {
  kolcsonzok: any;
  feliratkozas = new Subscription();
  constructor(private base:BaseService){

  }

  ngOnInit(): void {
    this.feliratkozas= this.base.getKolcsonzok().subscribe(
      (res)=>{
        this.kolcsonzok=res
        if (this.kolcsonzok){
          for (let i = 0; i < this.kolcsonzok.length; i++) {
            this.kolcsonzok[i].latszik=false;              
          }
        }
      }
    )
}

  ngOnDestroy(): void {
      if (this.feliratkozas) this.feliratkozas.unsubscribe()
  }
}
