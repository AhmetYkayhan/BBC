<template>
  <div class="mt-4">
    <!--Widget 1 -->
    <h1 class="homeTitle">Sizin İçin</h1>
    <v-row>
      <v-flex>
        <v-tabs>
          <v-tabs-slider></v-tabs-slider>
          <v-tab
            v-for="i in ['Günlük', 'Haftalık', 'Aylık']"
            :key="i"
            :href="`#tab-${i}`"
          >
            {{ i }}
          </v-tab>
          <v-tab-item
            v-for="i in ['Günlük', 'Haftalık', 'Aylık']"
            :key="i"
            :value="'tab-' + i"
          >
            <v-card class="ma-1 pa-1" style="width:100%">
              <v-flex v-for="(item, i) in [1, 2, 3, 4, 5, 6,7,8,9,10]" :key="i">
                <v-list-item>                 
                  <v-list-item-content>
                    <v-list-item-title style="text-align:center;"
                      >Single-line item</v-list-item-title
                    >
                  </v-list-item-content>
                </v-list-item>
              </v-flex>
            </v-card>
          </v-tab-item>
        </v-tabs>
      </v-flex>
    </v-row>
    <!-- Widget 1-->
  </div>
</template>

<script>
import { rotData } from "../../assets/data/data";
export default {
  name: "PopularCategory",
};
</script>
