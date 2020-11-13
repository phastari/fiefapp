import { v4 as uuidv4 } from 'uuid';

import type { IPerson } from './person';

interface IBoatbuilder {
  boatId?: string;
  shipyardId: string;
}

export class Boatbuilder implements IBoatbuilder, IPerson {
  readonly id: string;
  boatId?: string;
  shipyardId: string;
  name: string;
  resources: number;
  skill: number;
  loyalty: number;
  age: number;

  constructor(shipyardId: string) {
    this.id = uuidv4();
    this.boatId = undefined;
    this.shipyardId = shipyardId;
    this.name = '';
    this.resources = 0;
    this.skill = 0;
    this.loyalty = 0;
    this.age = 0;
  }
}
