<script lang="ts">
  import Incomes from './incomes/incomes.svelte';
  import Information from './information/information.svelte';
  import Stewards from './stewards/stewards.svelte';
  import Subsidiaries from './subsidiaries/subsidiaries.svelte';
  import { onDestroy, onMount } from 'svelte';
  import { buildingAlternatives } from '../../stores/building-alternatives';
  import { getBuildings } from '../../api/get-building-alternatives';
  import Buildings from './buildings/buildings.svelte';
  import { client } from '../../api/apollo';
  import gql from 'graphql-tag';

  onMount(async () => {
    const buildings = await getBuildings();
    buildingAlternatives.set(buildings);
  });

  const openTab = (event: MouseEvent, tab: string) => {
    if (event !== null && (tab !== null || tab !== '')) {
      let tabcontents: HTMLCollectionOf<Element> = document.getElementsByClassName(
        'tabcontent'
      );
      let tablinks: HTMLCollectionOf<Element> = document.getElementsByClassName(
        'tablink'
      );

      for (let i = 0; i < tabcontents.length; i++) {
        let tabcontent = tabcontents[i] as HTMLDivElement;
        tabcontent.style.display = 'none';
      }

      for (let i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(' active', '');
      }

      let div = document.getElementById(tab) as HTMLDivElement;
      if (div !== null) div.style.display = 'block';

      let target = event.currentTarget as HTMLDivElement;
      if (target !== null) target.className += ' active';
    }
  };
  const query = gql`
    subscription {
      buildingChanged {
        type
        actionSucceeded
        deletedId
        entity {
          id
          type
        }
      }
    }
  `;

  const subscription = client.subscribe({ query }).subscribe((response) => {
    buildingAlternatives.update(array => [...array, response.data.buildingAlternativeAdded])
    console.log($buildingAlternatives);
  });
  
  onDestroy(() => subscription.unsubscribe());
</script>

<style>
  .tab {
    overflow: hidden;
    background-color: #f1f1f1;
  }

  .tab button {
    background-color: inherit;
    float: left;
    border: none;
    outline: none;
    cursor: pointer;
    padding: 14px 16px;
    transition: 0.3s;
  }

  .tab button:hover {
    background-color: #ddd;
  }

  .tab button.active {
    background-color: #ccc;
  }

  .tabcontent {
    display: none;
    padding: 6px 12px;
  }
</style>

<div class="tab">
  <button class="tablink active" on:click={(event) => openTab(event, 'information')}>
    Information
  </button>
  <button class="tablink" on:click={(event) => openTab(event, 'stewards')}>
    Förvaltare
  </button>
  <button class="tablink" on:click={(event) => openTab(event, 'incomes')}>
    Inkomster
  </button>
  <button class="tablink" on:click={(event) => openTab(event, 'subsidiaries')}>
    Binäringar
  </button>
  <button class="tablink" on:click={(event) => openTab(event, 'buildings')}>
    Byggnader
  </button>
</div>

<div id="information" class="tabcontent">
  <Information />
</div>

<div id="stewards" class="tabcontent">
  <Stewards />
</div>

<div id="incomes" class="tabcontent">
  <Incomes />
</div>

<div id="subsidiaries" class="tabcontent">
  <Subsidiaries />
</div>

<div id="buildings" class="tabcontent">
  <Buildings />
</div>
