import type { IPerson } from './person';

interface IMerchant {
  cargoId?: string;
  portId?: string;
  soldiers: string[];
  status: string;
}

export class Merchant implements IMerchant, IPerson {
  id: string;
  cargoId?: string;
  portId?: string;
  soldiers: string[];
  status: string;
  name: string;
  age: number;
  resources: number;
  loyalty: number;
  skill: number;

  constructor() {
    this.id = '';
    this.cargoId = undefined;
    this.portId = undefined;
    this.soldiers = [];
    this.status = '';
    this.name = '';
    this.age = 0;
    this.resources = 0;
    this.loyalty = 0;
    this.skill = 0;
  }
}
