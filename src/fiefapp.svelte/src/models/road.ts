import { v4 as uuidv4 } from 'uuid';
import { RoadAlternative } from './settings/road-alternative';

interface IRoad {
  roadId: string;
  soldierIds: string[];
  description: string;
  type: RoadType;
  upgradeBaseCost: number;
  upgradeStoneCost: number;
  modificationFactor: number;
}

export enum RoadType {
  PATHS = 'PATH',
  ROADS = 'ROADS',
  PAVED = 'PAVED',
  HIGHWAY = 'HIGHWAY',
}

export class Road implements IRoad {
  readonly roadId: string;
  soldierIds: string[];

  constructor(
    public description: string,
    public type: RoadType,
    public upgradeBaseCost: number,
    public upgradeStoneCost: number,
    public modificationFactor: number
  ) {
    this.roadId = uuidv4();
    this.soldierIds = [];
  }

  public createAlternative(): RoadAlternative {
    return new RoadAlternative(
      this.type.toString(),
      this.description,
      this.upgradeBaseCost,
      this.upgradeStoneCost,
      this.modificationFactor
    );
  }
}

export const roads: Road[] = [
  new Road('Stigar', RoadType.PATHS, 2, 0, 0.3),
  new Road('Väg', RoadType.ROADS, 32, 1000, 1),
  new Road('Stenlagd väg', RoadType.PAVED, 65, 15000, 3.2),
  new Road('Kunglig landsväg', RoadType.HIGHWAY, 0, 0, 6.8),
];
