#pragma once
#include<vector>

class StalinSort
{
public:
	static void stalinSort(std::vector<int>& arr) {
		//if (arr.empty())return;
		//std::vector<int>res;
		//res.push_back(arr[0]);
		//for (int i = 1; i < arr.size(); i++)
		//{
		//	if (arr[i] >= res.back())
		//	{
		//		res.push_back(arr[i]);
		//	}
		//}
		//arr = res;

		//if (arr.empty())return;
		//int last = 0;
		//for (int i = 1; i < arr.size(); i++)
		//{
		//	if (arr[i] >= arr[last])
		//	{
		//		last++;
		//		arr[last] = arr[i];
		//	}
		//}
		//arr.resize(last + 1);

		if (arr.empty())return;
		for (int i = 1; i < arr.size(); i++)
		{
			if (arr[i] < arr[i - 1])
			{
				arr.erase(arr.begin() + i);
				i--;
			}
		}


	}
};

