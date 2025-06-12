import { Injectable } from '@angular/core';
import { Usluga } from '../models/usluga';
import { Observable, of } from 'rxjs';
import { UslugaBody } from '../models/usluga-body';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ListaService {
  private static idGen = 1;

//   private lista: Usluga[] = [
//   { id: ListaService.idGen++, nazwa: "Malowanie ścian", wykonawca: "Jan Kowalski", rodzaj: "Budowlana", rok: 2023 },
//   { id: ListaService.idGen++, nazwa: "Naprawa laptopa", wykonawca: "TechFix Serwis", rodzaj: "Elektroniczna", rok: 2024 },
//   { id: ListaService.idGen++, nazwa: "Projekt ogrodu", wykonawca: "Zielony Zakątek", rodzaj: "Projektowa", rok: 2022 },
//   { id: ListaService.idGen++, nazwa: "Tłumaczenie dokumentów", wykonawca: "Anna Nowak", rodzaj: "Językowa", rok: 2021 },
//   { id: ListaService.idGen++, nazwa: "Kurs programowania", wykonawca: "CodeAcademy", rodzaj: "Edukacyjna", rok: 2025 }
// ];

private readonly baseURL='http://localhost:5002/api/Usluga';

constructor(private httpClient: HttpClient){}
  get(): Observable<Usluga[]> {
    //return of(this.lista);
    return this.httpClient.get<Usluga[]>(this.baseURL);
  }

  getByID(id: number): Observable<Usluga> {
    // const ksiazka = this.lista.find(k => k.id === id);
    // if(ksiazka == null) {
    //   throw new Error('Nie znaleziono wskazanej książki');
    // }
    // return of(ksiazka);
    const url= `${this.baseURL}/${id}`;
    return this.httpClient.get<Usluga>(url);
  }

  delete(id: number): Observable<void> {
    // this.lista = this.lista.filter(k => k.id !== id);
    // return of(undefined);
    const url= `${this.baseURL}/${id}`;
    return this.httpClient.delete<void>(url);
  }

  put(id: number, body: UslugaBody): Observable<void> {
    // const ksiazka = this.lista.find(k => k.id === id);
    // if(ksiazka == null) { 
    //   throw new Error('Nie znaleziono wskazanej książki');
    // }

    // ksiazka.wykonawca = body.wykonawca;
    // ksiazka.rodzaj = body.rodzaj;
    // ksiazka.rok = body.rok;
    // ksiazka.nazwa = body.nazwa;

    // return of(undefined);

    const url= `${this.baseURL}/${id}`;
    return this.httpClient.put<void>(url, body);
  }

  post(body: UslugaBody): Observable<void> {
    // const ksiazka: Usluga = {
    //   id: ListaService.idGen++,
    //   wykonawca: body.wykonawca,
    //   rodzaj: body.rodzaj,
    //   rok: body.rok,
    //   nazwa: body.nazwa
    // };

    // this.lista.push(ksiazka);

    // return of(undefined);
    return this.httpClient.post<void>(this.baseURL,body);
  }
}
