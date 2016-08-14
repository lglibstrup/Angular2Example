import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';
import { Network } from '../model/network';
import variables = require('../app.var');
@Injectable()
export class NetworkService {
    private apiUrl = variables.apiUrl + "networks";
    constructor(private http: Http) { }
    getHeroes() {
        return this.http.get(this.apiUrl)
            .toPromise()
            .then(response =>  response.json() as Network[])
            .catch(this.handleError);
    }
    getNetwork(id: number) {
        let url = `${this.apiUrl}/${id}`;
        return this.http.get(url)
            .toPromise().then(response => response.json() as Network)
            .catch(this.handleError);
    }
    save(hero: Network): Promise<Network> {
        if (hero.networkId) {
            return this.put(hero);
        }
        return this.post(hero);
    }

    delete(hero: Network) {
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');
        let url = `${this.apiUrl}/${hero.networkId}`;
        return this.http
            .delete(url)
            .toPromise()
            .catch(this.handleError);
    }

    // Add new Hero
    private post(hero: Network): Promise<Network> {
        let headers = new Headers({
            'Content-Type': 'application/json'
        });
        return this.http
            .post(this.apiUrl, JSON.stringify(hero), { headers: headers })
            .toPromise()
            .then(res => res.json().data)
            .catch(this.handleError);
    }

    // Update existing Hero
    private put(hero: Network) {
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');
        let url = `${this.apiUrl}/${hero.networkId}`;
        return this.http
            .put(url, JSON.stringify(hero), { headers: headers })
            .toPromise()
            .then(() => hero)
            .catch(this.handleError);
    }

    private handleError(error: any) {
        console.error('An error occurred', error);
        return Promise.reject(error.message || error);
    }
}
