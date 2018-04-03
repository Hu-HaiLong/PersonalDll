using UnityEngine;
using System;

namespace HHL
{
    public class InputUtils
    {

        private Vector2 first = Vector2.zero;
        private Vector2 second = Vector2.zero;


        private Action<uint> callBack = null;

        public uint state = 0;

        public const uint LEFT_MOVE = 1 << 0;
        public const uint RIGHT_MOVE = 1 << 1;
        public const uint UP_MOVE = 1 << 2;
        public const uint DOWN_MOVE = 1 << 3;

        private float start_time = 0;

        public InputUtils(Action<uint> _callBack)
        {
            first = Vector2.zero;
            second = Vector2.zero;
            callBack = _callBack;
        }

        public static bool Check(uint check_value, uint move_value)
        {
            return (check_value & move_value) != 0;
        }

        public void Update(float distance = 80f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                first = Input.mousePosition;
            }
            if (Input.GetMouseButton(0))
            {
                start_time += Time.deltaTime;
            }
            if (Input.GetMouseButtonUp(0))
            {
                second = Input.mousePosition;
                Vector2 slideDirection = second - first;

                if (slideDirection.x > distance)// right   
                {
                    state |= RIGHT_MOVE;
                }
                else if (slideDirection.x < -distance) // left 
                {
                    state |= LEFT_MOVE;
                }

                if (slideDirection.y > distance)
                {
                    state |= UP_MOVE;
                }
                else if (slideDirection.y < -distance)
                {
                    state |= DOWN_MOVE;
                }

                if (start_time >= 0.13f)
                {
                    callBack(state);
                    start_time = 0;
                }

                state = 0;
                first = second;
            }
        }

    }

}
