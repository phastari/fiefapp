import { v4 as uuidv4 } from 'uuid';

interface IIndustry {
  industryId: string;
  name: string;
  stewardId?: string;
  needSteward: boolean;
  silver?: number;
  base?: number;
  luxury?: number;
  wood?: number;
  stone?: number;
  iron?: number;
}

export class Industry implements IIndustry {
  readonly industryId: string;
  name: string;
  stewardId?: string;
  needSteward: boolean;
  silver?: number;
  base?: number;
  luxury?: number;
  wood?: number;
  stone?: number;
  iron?: number;

  constructor() {
    this.industryId = uuidv4();
    this.name = '';
    this.stewardId = undefined;
    this.needSteward = false;
    this.silver = undefined;
    this.base = undefined;
    this.luxury = undefined;
    this.wood = undefined;
    this.stone = undefined;
    this.iron = undefined;
  }
}

export interface IShortIndustry {
  industryId: string;
  name: string;
}
