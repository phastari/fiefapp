interface IRoad {
  soldierIds: string[];
  name: string;
  type: RoadType;
  upgradeBaseCost: number;
  upgradeStoneCost: number;
  modificationFactor: number;
  dayswork: number;
}

export enum RoadType {
  PATHS = 'PATHS',
  ROADS = 'ROADS',
  PAVED = 'PAVED',
  HIGHWAY = 'HIGHWAY',
}

export class Road implements IRoad {
  soldierIds: string[];

  constructor(
    public type: RoadType,
    public name: string,
    public upgradeBaseCost: number,
    public upgradeStoneCost: number,
    public modificationFactor: number,
    public dayswork: number
  ) {
    this.soldierIds = [];
  }
}

export const emptyRoad: Road = {
  type: RoadType.ROADS,
  name: '',
  upgradeBaseCost: 0,
  upgradeStoneCost: 0,
  modificationFactor: 0,
  dayswork: 0,
  soldierIds: [],
};
