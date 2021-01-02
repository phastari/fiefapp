import type { IPerson } from './person';
import type { Shipyard } from './shipyard';

interface IBoatbuilder {
  id?: string;
  shipyard?: Shipyard;
}

export class Boatbuilder implements IBoatbuilder, IPerson {
  id: string;
  boatId?: string;
  shipyard?: Shipyard;
  name: string;
  resources: number;
  skill: number;
  loyalty: number;
  age: number;

  constructor() {
    this.id = '';
    this.boatId = undefined;
    this.shipyard = undefined;
    this.name = '';
    this.resources = 0;
    this.skill = 0;
    this.loyalty = 0;
    this.age = 0;
  }
}
