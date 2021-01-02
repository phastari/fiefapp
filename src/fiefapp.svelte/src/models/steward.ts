import type { IPerson } from './person';
import { generateName } from '../utils/name-generator/name.generator';
import { rollObt6 } from '../utils/dice-rolls/obt6';

interface ISteward {
  industryId?: string;
  developmentId?: string;
  fiefId?: string;
  marketId?: string;
  portId?: string;
  shipyardId?: string;
}

export class Steward implements ISteward, IPerson {
  id: string;
  name: string;
  age: number;
  skill: number;
  loyalty: number;
  resources: number;
  industryId?: string;
  developmentId?: string;
  fiefId?: string;
  marketId?: string;
  portId?: string;
  shipyardId?: string;

  constructor() {
    this.id = '';
    this.name = generateName(true);
    this.skill = rollObt6(1, 10).total;
    this.age = this.skill + rollObt6(4, 0).total;
    this.loyalty = 0;
    this.resources = 0;
    this.industryId = undefined;
    this.developmentId = undefined;
    this.fiefId = undefined;
    this.marketId = undefined;
    this.portId = undefined;
    this.shipyardId = undefined;
  }
}

export enum UpdateStewardPropertyType {
  NUMBER = 'NUMBER',
  STRING = 'STRING',
}
