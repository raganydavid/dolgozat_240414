import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  
  private url="http://172.16.16.136:5001/api/Kolcsonzok/"
  private tippUrl="http://172.16.16.136:5001/api/Kolcsonzesek/"
  private jatekosokSub = new BehaviorSubject(null)

  constructor(private http:HttpClient) { 
    this.loadKolcsonzok()
  }

  private loadKolcsonzok(){
      this.http.get(this.url).subscribe(
        (res:any)=>this.kolcsonzokSub.next(res)
      )
  }
  getKolcsonzok(){
    return this.kolcsonzokSub
  }

  newKolcs(kolcs:any){
    this.http.post(this.kolcsUrl,kolcs).forEach(
      ()=>this.loadKolcsonzok()
    )
  }
  updateKolcs(kolcs:any){
    this.http.put(this.kolcsUrl+kolcs.id,kolcs).forEach(
      ()=>this.loadKolcsonzok()
    )
  }

  deleteKolcs(kolcs:any){
    this.http.delete(this.kolcsUrl+kolcs.id).forEach(
      ()=>this.loadKolcsonzok()
    )
  }
  
}
