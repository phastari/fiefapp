import type { Inheritance } from '../inheritance';
import type { Livingcondition } from '../livingcondition';
import type { Road } from '../road';

export interface ISelectionAlternatives {
  roads: Road[];
  inheritances: Inheritance[];
  livingconditions: Livingcondition[];
}

export const initialSelectionAlternatives: ISelectionAlternatives = {
  roads: [],
  inheritances: [],
  livingconditions: [],
};
