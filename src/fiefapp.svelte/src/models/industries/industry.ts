interface IIndustry {
  id: string;
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
  id: string;
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
    this.id = '';
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
  id: string;
  name: string;
}
