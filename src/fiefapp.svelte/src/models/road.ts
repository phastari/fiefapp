interface IRoad {
  id: string;
  name: string;
  type?: RoadType;
  upgradeBaseCost: number;
  upgradeStoneCost: number;
  modificationFactor: number;
  dayswork: number;
  soldierIds: string[];
}

export enum RoadType {
  PATHS = 'PATHS',
  ROADS = 'ROADS',
  PAVED = 'PAVED',
  HIGHWAY = 'HIGHWAY',
}

export class Road implements IRoad {
  id: string;
  name: string;
  type?: RoadType;
  upgradeBaseCost: number;
  upgradeStoneCost: number;
  modificationFactor: number;
  dayswork: number;
  soldierIds: string[];

  constructor(
    id?: string,
    type?: RoadType,
    name?: string,
    upgradeBaseCost?: number,
    upgradeStoneCost?: number,
    modificationFactor?: number,
    dayswork?: number
  ) {
    this.id = id ? id : '';
    this.name = name ? name : '';
    this.type = type ? type : undefined;
    this.upgradeBaseCost = upgradeBaseCost ? upgradeBaseCost : 0;
    this.upgradeStoneCost = upgradeStoneCost ? upgradeStoneCost : 0;
    this.modificationFactor = modificationFactor ? modificationFactor : 0;
    this.dayswork = dayswork ? dayswork : 0;
    this.soldierIds = [];
  }
}
