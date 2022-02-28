using System;
using System.Collections.Generic;

//Drew a majority of the code from Unit 04 


namespace greed.Game.Casting
{  
    public class Cast
    {
        private Dictionary<string, List<Actor>> actors= new Dictionary<string, List<Actor>>();
    
        public Cast()
        {

        }

        public void add_actor (string group, Actor actor)
        {
            if (!actors.ContainsKey(group))
            {
                actors[group] =new List<Actor>();
            }    
            if (!actors[group].Contains(actor))
            {
                actors[group].Add(actor);
            }
        }
        public List<Actor> get_actors (string group)
        {
            List<Actor> results= new List<Actor>();
            if (actors.ContainsKey(group))
            {
                results.AddRange(actors[group]);
            }
            return results;
        }

        public List<Actor> get_all_actors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in actors.Values) 
            {
                results.AddRange(result);
            }
            return results;
        }
        public Actor get_first_actor(string group) 
        {
            Actor result = null;
            if (actors.ContainsKey(group)) 
            {
                if (actors[group].Count > 0)
                {
                    result = actors[group][0];
                }
            }
            return result;
        }


        public void remove_actor(string group, Actor actor)
        {

            if (actors.ContainsKey(group))
            {
                actors[group].Remove(actor);
            }
        }

    }
}

